#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "boatCreation.h"
#include "mapGeneration.h"

void computerBoatsCreation(int TABSIZE, char** map)
{
    //intializes random number generator
    srand(time(NULL));

    int orientation,x,y;
    int boatCreated = 0;
    int tabBoatSize[4];
    tabBoatSize[0] = 1; //numberBoatSize2
    tabBoatSize[1] = 2; //numberBoatSize3
    tabBoatSize[2] = 1; //numberBoatSize4
    tabBoatSize[3] = 1; //numberBoatSize5

    //will execute 4 times (from 5 to 2)
    for(int all=5 ; all>=2 ; all--)
    {
        //will execute numberBoeatSize of 'all' times
        for(int i=0 ; i<tabBoatSize[all-2] ; i++)
        {
            //random for vertical or horizontal boat
            orientation = (rand()%2)+1;
            //printf("orientation : %i\n",orientation);

            //if the computer wants a horizontal boat
            if(orientation == 1)
            {
                do{
                    x = rand() % TABSIZE;
                    y = rand() % TABSIZE;
                    //printf("x : %i\n",x);
                    //printf("y : %i\n",y);
                    boatCreated = createHorizontalBoat(TABSIZE, all, map, x, y); 
                //if the boat doesn't respect conditions, ask again for coordinates
                }while(boatCreated == 0);
            //if the computer wants a vertical boat   
            }else if(orientation == 2)
            {
                do{
                    x = rand() % TABSIZE;
                    y = rand() % TABSIZE;
                    boatCreated = createVerticalBoat(TABSIZE, all, map, x, y); 
                //if the boat doesn't respect conditions, ask again for coordinates
                }while(boatCreated == 0);
            }
        }
    }
}

void boatsCreationLoop(int TABSIZE, char** map)
{
    int orientation,y;
    char x;
    int boatCreated = 1;
    int tabBoatSize[4];
    tabBoatSize[0] = 1; //numberBoatSize2
    tabBoatSize[1] = 2; //numberBoatSize3
    tabBoatSize[2] = 1; //numberBoatSize4
    tabBoatSize[3] = 1; //numberBoatSize5

    //will execute 4 times (from 5 to 2)
    for(int all=5 ; all>=2 ; all--)
    {
        //will execute numberBoeatSize of 'all' times
        for(int i=0 ; i<tabBoatSize[all-2] ; i++)
        {
            //ask for a vertical or horizontal boat
            printf("Let's create a %i size boat. First, write 1 for an\n",all);
            printf("horizontal boat or 2 for a vertical one : ");
            scanf("%i",&orientation);

            //if the player wants a horizontal boat
            if(orientation == 1)
            {
                do{
                    printf("coucou 1 : %i\n",boatCreated);
                    if(boatCreated == 0){printf("\nThe boat can't be placed there.\n");}
                    printf("Please enter the coordinates of the upper left square of the boat (eg. C 4) : ");
                    scanf("%c %i",&x,&y);
                    printf("\n");
                    //x-'A' because 'C'-'A'=2 and y-1 because for the computer, its starts at 0
                    boatCreated = createHorizontalBoat(TABSIZE, all, map, x-'A', y-1); 
                //if the boat doesn't respect conditions, ask again for coordinates
                }while(boatCreated == 0);
                printMap(TABSIZE, map);
                printf("\n");

            //if the player wants a vertical boat
            }else if(orientation == 2)
            {
                do{
                    printf("coucou 2 : %i\n",boatCreated);
                    if(boatCreated == 0){printf("\nThe boat can't be placed there.\n");}
                    printf("Please enter the coordinates of the upper left square of the boat (eg. C 4) : ");
                    scanf("%c %i",&x,&y);
                    printf("\n");
                    //x-'A' because 'C'-'A'=2 and y-1 because for the computer, its starts at 0
                    boatCreated = createVerticalBoat(TABSIZE, all, map, x-'A', y-1); 
                //if the boat doesn't respect conditions, ask again for coordinates
                }while(boatCreated == 0);
                printMap(TABSIZE, map);
            }
        }
    }
}

int createHorizontalBoat(int TABSIZE, int boatSize, char** map, int X, int Y)
{
    int canBeCreated = 1; // 0 : false and 1 : true

    //first checks if all cases are free
    for(int i=0 ; i<boatSize ; i++)
    {
        if(map[Y][X+i]!='~')
        {
            canBeCreated = 0;
        }
    }

    //if every cases needed are free, create the boat
    if(canBeCreated == 1)
    {
        for(int i=0 ; i<boatSize ; i++ || X+boatSize > TABSIZE)
        {
            map[Y][X+i] = '@';
        }
        return 1;
    }

    //otherwise, return false
    else
    {
        return 0;
    }  
}

int createVerticalBoat(int TABSIZE, int boatSize, char** map, int X, int Y)
{
    int canBeCreated = 1; // 0 : false and 1 : true

    //first checks if all cases are free
    for(int i=0 ; i<boatSize ; i++)
    {
        if(map[Y+i][X]!='~' || Y+boatSize > TABSIZE)
        {
            canBeCreated = 0;
        }
    }

    //if every cases needed are free, create the boat
    if(canBeCreated == 1)
    {
        for(int i=0 ; i<boatSize ; i++)
        {
            map[Y+i][X] = '@';
        }
        return 1;
    }
    //otherwise, return false
    else
    {
        return 0;
    }  
}