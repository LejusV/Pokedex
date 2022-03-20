using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gyarados PokemonInstance Class
	#region Gyarados
	public class Gyarados : PokemonInstance
	{
		#region Gyarados Constructors
		/// <summary>
		/// Gyarados Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gyarados(string nickname, int level)
		: base(
				GyaradosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Constructor only waiting for a Level
		/// </summary>
		public Gyarados(int level)
		: this( "Gyarados", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Constructor waiting for no params
		/// </summary>
		/*
		public Gyarados() : this( "Gyarados", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}