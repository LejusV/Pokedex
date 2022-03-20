using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Skorupi PokemonInstance Class
	#region Skorupi
	public class Skorupi : PokemonInstance
	{
		#region Skorupi Constructors
		/// <summary>
		/// Skorupi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Skorupi(string nickname, int level)
		: base(
				SkorupiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Constructor only waiting for a Level
		/// </summary>
		public Skorupi(int level)
		: this( "Skorupi", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Constructor waiting for no params
		/// </summary>
		/*
		public Skorupi() : this( "Skorupi", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}