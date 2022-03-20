using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arcanine PokemonInstance Class
	#region Arcanine
	public class Arcanine : PokemonInstance
	{
		#region Arcanine Constructors
		/// <summary>
		/// Arcanine Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arcanine(string nickname, int level)
		: base(
				ArcanineSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Constructor only waiting for a Level
		/// </summary>
		public Arcanine(int level)
		: this( "Arcanine", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arcanine Constructor waiting for no params
		/// </summary>
		/*
		public Arcanine() : this( "Arcanine", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}