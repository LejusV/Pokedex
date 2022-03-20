using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meganium PokemonInstance Class
	#region Meganium
	public class Meganium : PokemonInstance
	{
		#region Meganium Constructors
		/// <summary>
		/// Meganium Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Meganium(string nickname, int level)
		: base(
				MeganiumSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Constructor only waiting for a Level
		/// </summary>
		public Meganium(int level)
		: this( "Meganium", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Constructor waiting for no params
		/// </summary>
		/*
		public Meganium() : this( "Meganium", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}