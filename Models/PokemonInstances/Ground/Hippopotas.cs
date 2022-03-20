using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hippopotas PokemonInstance Class
	#region Hippopotas
	public class Hippopotas : PokemonInstance
	{
		#region Hippopotas Constructors
		/// <summary>
		/// Hippopotas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hippopotas(string nickname, int level)
		: base(
				HippopotasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Constructor only waiting for a Level
		/// </summary>
		public Hippopotas(int level)
		: this( "Hippopotas", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippopotas Constructor waiting for no params
		/// </summary>
		/*
		public Hippopotas() : this( "Hippopotas", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}