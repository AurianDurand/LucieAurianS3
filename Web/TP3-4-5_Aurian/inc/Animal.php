<!DOCTYPE html>
<style>
    table, tr, td {
        border : 1px solid black;
    }
</style>

<?php

class Animal {

    private $_id;
    private $_nom;
    private $_espece;
    private $_cri;
    private $_proprietaire;
    private $_age;


    public function __construct(array $donnees) 
    { 
        $this->hydrate($donnees);
    }

    public function toString()
    {
        //return "<td>Identifiant : ".$this->_id."</td><td>Nom : ".$this->_nom."</td><td>Espece : ".$this->_espece."</td><td>Cri : ".$this->_cri."</td><td>Proprietaire : ".$this->_proprietaire."</td><td>Age : ".$this->_age."</td>";
        return "Identifiant : ".$this->_id." | Nom : ".$this->_nom." | Espece : ".$this->_espece." | Cri : ".$this->_cri." | Proprietaire : ".$this->_proprietaire." | Age : ".$this->_age;
    }

    public function hydrate(array $donnees)
    {
        foreach($donnees as $key => $value)
        {
            // On récupère le nom du setter correspondant à l'attribut.
            $method = 'set'.ucfirst($key);
            // Si le setter correspondant existe.
            if (method_exists($this, $method)) {
                // On appelle le setter.
                $this->$method($value); 
            }
        }
    }

    //get
    public function getId()
    {
        return $this->_id;
    } 

    public function getNom()
    {
        return $this->_nom;
    } 

    public function getEspece()
    {
        return $this->_espece;
    } 

    public function getCri()
    {
        return $this->_cri;
    } 

    public function getProprietaire()
    {
        return $this->_proprietaire;
    } 

    public function getAGe()
    {
        return $this->_age;
    } 

    //set
    public function setId($id) 
    { 
        $id = (int) $id;
        if ($id > 0) {
            $this->_id = $id; 
        }
    }

    public function setNom($nom) 
    { 
        $this->_nom = $nom; 
    }

    public function setEspece($espece) 
    { 
        $this->_espece = $espece; 
    }

    public function setCri($cri) 
    { 
        $this->_cri = $cri; 
    }

    public function setProprietaire($proprietaire) 
    { 
        $this->_proprietaire = $proprietaire; 
    }

    public function setAge($age) 
    { 
        $this->_age = $age; 
    }

}