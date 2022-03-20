using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Furret PokemonInstance Class
	#region Furret
	public class Furret : PokemonInstance
	{
		#region Furret Constructors
		/// <summary>
		/// Furret Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Furret(string nickname, int level)
		: base(
				FurretSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Constructor only waiting for a Level
		/// </summary>
		public Furret(int level)
		: this( "Furret", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Furret Constructor waiting for no params
		/// </summary>
		/*
		public Furret() : this( "Furret", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}