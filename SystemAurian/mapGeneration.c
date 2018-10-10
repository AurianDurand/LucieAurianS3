#include <stdio.h>
#include <stdlib.h>
#include "mapGeneration.h"

int askForSize(){
    int size = 50;
    while(size > 26)
    {
        printf("Please enter the size of the map (between 1 and 26) : ");
        scanf("%i", &size); //read the input
    }
    return size;
}

void createMap(int TABSIZE, char** map){
    for(int i=0 ; i < TABSIZE ; i++){
        //map's table dynamic allocation
        map[i] = (char*) calloc(TABSIZE, sizeof(char));
        //then, table filling with empty squares
        for(int j=0 ; j < TABSIZE ; j++){
            map[i][j]='~';
        }
    }
}

void printMap(int TABSIZE, char** map){
    char letter = 'A';
    printf("  ");
    //print the first row (letters)
    for(int i=0 ; i<TABSIZE ; i++){
        printf(" %c",letter+i);
    }
    printf("\n");
    //print the rest
    for(int x=0 ; x < TABSIZE ; x++){
        //print the first column (numbers)
        if(x<9){
            printf("%i  ",1 + x);
        }else{
            printf("%i ",1 + x);
        }
        //print the map
        for(int y=0 ; y < TABSIZE ; y++){
            printf("%c ",map[x][y]);
        }
        printf("\n");
    }
}

void print2Maps(int TABSIZE, char** map1, char** map2)
{
    //display map's name
    printf("\n   Player's map");
    for(int i=0 ; i<TABSIZE-5 ; i++)
    {
        printf("  ");
    }
    printf("    Computer's map\n");

    //start to display maps
    
    char letter = 'A';
    printf("  ");
    //print the first row (letters)
    for(int i=0 ; i<TABSIZE ; i++){
        printf(" %c",letter+i);
    }
    printf("      ");
    for(int i=0 ; i<TABSIZE ; i++){
        printf(" %c",letter+i);
    }
    printf("\n");
    //print the rest
    for(int x=0 ; x < TABSIZE ; x++){

        //first map

        //print the first column (numbers)
        if(x<9){
            printf("%i  ",1 + x);
        }else{
            printf("%i ",1 + x);
        }
        //print the map
        for(int y=0 ; y < TABSIZE ; y++){
            printf("%c ",map1[x][y]);
        }

        //second map

        //print the first column (numbers)
        if(x<9){
            printf("   %i  ",1 + x);
        }else{
            printf("   %i ",1 + x);
        }
        //print the map
        for(int y=0 ; y < TABSIZE ; y++){
            printf("%c ",map2[x][y]);
        }

        printf("\n");
    }
}
