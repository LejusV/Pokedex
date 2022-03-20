using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gogoat PokemonInstance Class
	#region Gogoat
	public class Gogoat : PokemonInstance
	{
		#region Gogoat Constructors
		/// <summary>
		/// Gogoat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gogoat(string nickname, int level)
		: base(
				GogoatSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Constructor only waiting for a Level
		/// </summary>
		public Gogoat(int level)
		: this( "Gogoat", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gogoat Constructor waiting for no params
		/// </summary>
		/*
		public Gogoat() : this( "Gogoat", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}