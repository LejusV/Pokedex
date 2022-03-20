using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hydreigon PokemonInstance Class
	#region Hydreigon
	public class Hydreigon : PokemonInstance
	{
		#region Hydreigon Constructors
		/// <summary>
		/// Hydreigon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hydreigon(string nickname, int level)
		: base(
				HydreigonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Constructor only waiting for a Level
		/// </summary>
		public Hydreigon(int level)
		: this( "Hydreigon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hydreigon Constructor waiting for no params
		/// </summary>
		/*
		public Hydreigon() : this( "Hydreigon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}