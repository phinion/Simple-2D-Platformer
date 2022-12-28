using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
	int Health { get;}
	void TakeDamage(int amount);
	void Heal(int amount);
	void Die();
}
