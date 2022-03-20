using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rhyhorn PokemonInstance Class
	#region Rhyhorn
	public class Rhyhorn : PokemonInstance
	{
		#region Rhyhorn Constructors
		/// <summary>
		/// Rhyhorn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rhyhorn(string nickname, int level)
		: base(
				RhyhornSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Constructor only waiting for a Level
		/// </summary>
		public Rhyhorn(int level)
		: this( "Rhyhorn", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyhorn Constructor waiting for no params
		/// </summary>
		/*
		public Rhyhorn() : this( "Rhyhorn", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}