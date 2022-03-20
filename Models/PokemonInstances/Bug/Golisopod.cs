using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Golisopod PokemonInstance Class
	#region Golisopod
	public class Golisopod : PokemonInstance
	{
		#region Golisopod Constructors
		/// <summary>
		/// Golisopod Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Golisopod(string nickname, int level)
		: base(
				GolisopodSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Constructor only waiting for a Level
		/// </summary>
		public Golisopod(int level)
		: this( "Golisopod", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golisopod Constructor waiting for no params
		/// </summary>
		/*
		public Golisopod() : this( "Golisopod", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}