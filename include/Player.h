#pragma once

#include "GameObject.h"
#include "LUAScriptManager.h"

/**
* @class NPC
* @brief Class for creating NPCs
*
* @author Morgan Smolder
* @version 01
* @date 15/04/2018
*/
class Player : public GameObject
{
public:
	Player(Identifiers & id, vec3 pos, ResourceList & list);
	Player();
	Player(const Player & tocpy);

	GameObject* create();

	/**
	* @brief Update the player object.
	* 
	* @param time - The system time.
	*/
	void update(float time);

	/**
	* @brief Render the player object.
	*/
	void render();

	/**
	* @brief Get the center offset vector of the player.
	*
	* @return vec3 - The center offset vector of the player.
	*/
	vec3 getCenterOffset();

	/**
	* @brief Find out if the player is collidable.
	* 
	* @return bool - If the player is collidable or not.
	*/
	bool isCollidable();

	void drawModel(vec3 & trans, float rot);

	const vec3 & getFront();

	bool playerDefaultMessageHandler(Message & tocheck);
private:
	/// The direction the player should be facing.
	vec3 front;
};

