using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Exeggcute PokemonInstance Class
	#region Exeggcute
	public class Exeggcute : PokemonInstance
	{
		#region Exeggcute Constructors
		/// <summary>
		/// Exeggcute Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Exeggcute(string nickname, int level)
		: base(
				ExeggcuteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Constructor only waiting for a Level
		/// </summary>
		public Exeggcute(int level)
		: this( "Exeggcute", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Exeggcute Constructor waiting for no params
		/// </summary>
		/*
		public Exeggcute() : this( "Exeggcute", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}