using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meloetta-Aria PokemonInstance Class
	#region Meloetta-Aria
	public class MeloettaAria : PokemonInstance
	{
		#region Meloetta-Aria Constructors
		/// <summary>
		/// Meloetta-Aria Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeloettaAria(string nickname, int level)
		: base(
				MeloettaAriaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Constructor only waiting for a Level
		/// </summary>
		public MeloettaAria(int level)
		: this( "Meloetta-Aria", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meloetta-Aria Constructor waiting for no params
		/// </summary>
		/*
		public MeloettaAria() : this( "Meloetta-Aria", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}