using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lunatone PokemonInstance Class
	#region Lunatone
	public class Lunatone : PokemonInstance
	{
		#region Lunatone Constructors
		/// <summary>
		/// Lunatone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lunatone(string nickname, int level)
		: base(
				LunatoneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Constructor only waiting for a Level
		/// </summary>
		public Lunatone(int level)
		: this( "Lunatone", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Constructor waiting for no params
		/// </summary>
		/*
		public Lunatone() : this( "Lunatone", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}