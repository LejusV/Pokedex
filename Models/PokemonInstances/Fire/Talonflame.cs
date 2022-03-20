using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Talonflame PokemonInstance Class
	#region Talonflame
	public class Talonflame : PokemonInstance
	{
		#region Talonflame Constructors
		/// <summary>
		/// Talonflame Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Talonflame(string nickname, int level)
		: base(
				TalonflameSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Constructor only waiting for a Level
		/// </summary>
		public Talonflame(int level)
		: this( "Talonflame", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Talonflame Constructor waiting for no params
		/// </summary>
		/*
		public Talonflame() : this( "Talonflame", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}