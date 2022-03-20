using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Feebas PokemonInstance Class
	#region Feebas
	public class Feebas : PokemonInstance
	{
		#region Feebas Constructors
		/// <summary>
		/// Feebas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Feebas(string nickname, int level)
		: base(
				FeebasSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Constructor only waiting for a Level
		/// </summary>
		public Feebas(int level)
		: this( "Feebas", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Feebas Constructor waiting for no params
		/// </summary>
		/*
		public Feebas() : this( "Feebas", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}