using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Typhlosion PokemonInstance Class
	#region Typhlosion
	public class Typhlosion : PokemonInstance
	{
		#region Typhlosion Constructors
		/// <summary>
		/// Typhlosion Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Typhlosion(string nickname, int level)
		: base(
				TyphlosionSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Constructor only waiting for a Level
		/// </summary>
		public Typhlosion(int level)
		: this( "Typhlosion", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Typhlosion Constructor waiting for no params
		/// </summary>
		/*
		public Typhlosion() : this( "Typhlosion", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}