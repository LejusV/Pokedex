using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Decidueye PokemonInstance Class
	#region Decidueye
	public class Decidueye : PokemonInstance
	{
		#region Decidueye Constructors
		/// <summary>
		/// Decidueye Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Decidueye(string nickname, int level)
		: base(
				DecidueyeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Constructor only waiting for a Level
		/// </summary>
		public Decidueye(int level)
		: this( "Decidueye", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Decidueye Constructor waiting for no params
		/// </summary>
		/*
		public Decidueye() : this( "Decidueye", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}