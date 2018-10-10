#include <stdio.h>
#include <stdlib.h>
#include "mapGeneration.h"
#include "boatCreation.h"
#include "automaton.h"

int main(void)
{
    //map's size
    const int TABSIZE = askForSize(); 
    
    //maps declaration
    char ** mapPlayer = (char**)calloc(TABSIZE, sizeof(char*)); 
    char ** mapEnnemy = (char**)calloc(TABSIZE, sizeof(char*));
    char ** mapComputer = (char**)calloc(TABSIZE, sizeof(char*)); 
    
    //maps creation
    createMap(TABSIZE, mapPlayer);
    createMap(TABSIZE, mapEnnemy);
    createMap(TABSIZE, mapComputer);

    computerBoatsCreation(TABSIZE,mapComputer);

    printMap(TABSIZE,mapComputer);
    
    
    //boats creation 
    //create2SizeBoat(TABSIZE, mapPlayer,6,3);

    //map display
    printMap(TABSIZE, mapPlayer);

    boatsCreationLoop(TABSIZE, mapPlayer);

    //here add the generation of the computer boats!!!

    print2Maps(TABSIZE, mapPlayer, mapComputer);
    
    

    return 0;
}