using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Meowstic-Male PokemonInstance Class
	#region Meowstic-Male
	public class MeowsticMale : PokemonInstance
	{
		#region Meowstic-Male Constructors
		/// <summary>
		/// Meowstic-Male Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeowsticMale(string nickname, int level)
		: base(
				MeowsticMaleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Constructor only waiting for a Level
		/// </summary>
		public MeowsticMale(int level)
		: this( "Meowstic-Male", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meowstic-Male Constructor waiting for no params
		/// </summary>
		/*
		public MeowsticMale() : this( "Meowstic-Male", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}