using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Misdreavus PokemonInstance Class
	#region Misdreavus
	public class Misdreavus : PokemonInstance
	{
		#region Misdreavus Constructors
		/// <summary>
		/// Misdreavus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Misdreavus(string nickname, int level)
		: base(
				MisdreavusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Constructor only waiting for a Level
		/// </summary>
		public Misdreavus(int level)
		: this( "Misdreavus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Misdreavus Constructor waiting for no params
		/// </summary>
		/*
		public Misdreavus() : this( "Misdreavus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}