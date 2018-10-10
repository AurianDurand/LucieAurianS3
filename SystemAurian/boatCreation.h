#ifndef BOATCREATION_H
#define BOATCREATION_H

void computerBoatsCreation(int TABSIZE, char** map);
void boatsCreationLoop(int TABSIZE, char** map);
int createHorizontalBoat(int TABSIZE, int boatSize, char** map, int X, int Y);
int createVerticalBoat(int TABSIZE, int boatSize, char** map, int X, int Y);

#endif