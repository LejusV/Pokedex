using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Basculin-Red-Striped PokemonInstance Class
	#region Basculin-Red-Striped
	public class BasculinRedStriped : PokemonInstance
	{
		#region Basculin-Red-Striped Constructors
		/// <summary>
		/// Basculin-Red-Striped Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BasculinRedStriped(string nickname, int level)
		: base(
				BasculinRedStripedSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Constructor only waiting for a Level
		/// </summary>
		public BasculinRedStriped(int level)
		: this( "Basculin-Red-Striped", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Basculin-Red-Striped Constructor waiting for no params
		/// </summary>
		/*
		public BasculinRedStriped() : this( "Basculin-Red-Striped", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}