using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Landorus-Incarnate PokemonInstance Class
	#region Landorus-Incarnate
	public class LandorusIncarnate : PokemonInstance
	{
		#region Landorus-Incarnate Constructors
		/// <summary>
		/// Landorus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LandorusIncarnate(string nickname, int level)
		: base(
				LandorusIncarnateSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Constructor only waiting for a Level
		/// </summary>
		public LandorusIncarnate(int level)
		: this( "Landorus-Incarnate", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Constructor waiting for no params
		/// </summary>
		/*
		public LandorusIncarnate() : this( "Landorus-Incarnate", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}