using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drifloon PokemonInstance Class
	#region Drifloon
	public class Drifloon : PokemonInstance
	{
		#region Drifloon Constructors
		/// <summary>
		/// Drifloon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drifloon(string nickname, int level)
		: base(
				DrifloonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Constructor only waiting for a Level
		/// </summary>
		public Drifloon(int level)
		: this( "Drifloon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifloon Constructor waiting for no params
		/// </summary>
		/*
		public Drifloon() : this( "Drifloon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}