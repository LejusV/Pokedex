using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Omastar PokemonInstance Class
	#region Omastar
	public class Omastar : PokemonInstance
	{
		#region Omastar Constructors
		/// <summary>
		/// Omastar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Omastar(string nickname, int level)
		: base(
				OmastarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Constructor only waiting for a Level
		/// </summary>
		public Omastar(int level)
		: this( "Omastar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omastar Constructor waiting for no params
		/// </summary>
		/*
		public Omastar() : this( "Omastar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}