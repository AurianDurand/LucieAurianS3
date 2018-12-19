<?php

class AnimauxManager {

    private $_db; //PDO's instance

    public function __construct($db) 
    { 
        $this->setDb($db);
    }

    public function get($id) 
    {
        $id = (int) $id;
        $q = $this->_db->query('SELECT id, nom, espece, cri, proprietaire, age FROM animaux WHERE id = '.$id);
        $donnees = $q->fetch(PDO::FETCH_ASSOC); 
        return new Animal($donnees);
    }

    public function getList() 
    {
        $animal = array();
        $q = $this->_db->query('SELECT id, nom, espece, cri, proprietaire, age FROM animaux ORDER BY nom');
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC)) 
        { 
            $animal[] = new Animal($donnees);
        }
        return $animal;
    }

    public function add(Animal $animal) 
    {
        $q = $this->_db->prepare('INSERT INTO animaux SET nom = :nom,
            espece = :espece, cri = :cri, proprietaire = :proprietaire, age = :age');
        $q->bindValue(':nom', $animal->getNom());
        $q->bindValue(':espece', $animal->getEspece()); 
        $q->bindValue(':cri', $animal->getCri()); 
        $q->bindValue(':proprietaire', $animal->getProprietaire()); 
        $q->bindValue(':age', $animal->getAge(), PDO::PARAM_INT);
        $q->execute();
    }

    public function modify(Animal $animal)
    {
        if($animal->getNom()!="")
        {
            $q = $this->_db->prepare('UPDATE animaux SET nom = :nom WHERE id = :id');
            $q->bindValue(':id', $animal->getId());
            $q->bindValue(':nom', $animal->getNom());
            $q->execute();
        }
        if($animal->getEspece()!="")
        {
            $q = $this->_db->prepare('UPDATE animaux SET espece = :espece WHERE id = :id');
            $q->bindValue(':id', $animal->getId());
            $q->bindValue(':espece', $animal->getEspece());
            $q->execute();
        }
        if($animal->getCri()!="")
        {
            $q = $this->_db->prepare('UPDATE animaux SET cri = :cri WHERE id = :id');
            $q->bindValue(':id', $animal->getId());
            $q->bindValue(':cri', $animal->getCri());
            $q->execute();
        }
        if($animal->getProprietaire()!="")
        {
            $q = $this->_db->prepare('UPDATE animaux SET proprietaire = :proprietaire WHERE id = :id');
            $q->bindValue(':id', $animal->getId());
            $q->bindValue(':proprietaire', $animal->getProprietaire());
            $q->execute();
        }
        if($animal->getAge()!=0 || $animal->getAge()!=null)
        {
            $q = $this->_db->prepare('UPDATE animaux SET age = :age WHERE id = :id');
            $q->bindValue(':id', $animal->getId());
            $q->bindValue(':age', $animal->getAge());
            $q->execute(); 
        }
    }

    public function canBeCreated(Animal $animal):bool
    {
        $exist = true;
        $liste = $this->getList();
        foreach($liste as $key => $value)
        {
            //if the row already exist
            if($animal->getNom()==$value->getNom())
            {
                if($animal->getEspece()==$value->getEspece())
                {
                    if($animal->getCri()==$value->getCri())
                    {
                        if($animal->getProprietaire()==$value->getProprietaire())
                        {
                            if($animal->getAge()==$value->getAge())
                            {
                                $exist = false;
                            }
                            else if($animal->getAge()==null)
                            {
                                $exist = false;
                            }
                            else if($animal->getAge()==0)
                            {
                                $exist = false;
                            }
                        }
                    }
                } 
            }
            //if every input is empty
            if($animal->getNom()==null && $animal->getEspece()==null && $animal->getCri()==null && $animal->getProprietaire()==null && $animal->getAge()==null)
            {
                $exist = false;
            } 
        }
        return $exist;
    }

    public function delete(Animal $animal) 
    { 
        $this->_db->exec('DELETE FROM animaux WHERE id = '.$animal->getId()); 
    }

    public function setDb(PDO $db) 
    { 
        $this->_db = $db;
    }

}