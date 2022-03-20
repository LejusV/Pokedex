using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lampent PokemonInstance Class
	#region Lampent
	public class Lampent : PokemonInstance
	{
		#region Lampent Constructors
		/// <summary>
		/// Lampent Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lampent(string nickname, int level)
		: base(
				LampentSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Constructor only waiting for a Level
		/// </summary>
		public Lampent(int level)
		: this( "Lampent", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Constructor waiting for no params
		/// </summary>
		/*
		public Lampent() : this( "Lampent", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}