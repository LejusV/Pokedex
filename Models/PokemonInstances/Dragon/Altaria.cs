using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Altaria PokemonInstance Class
	#region Altaria
	public class Altaria : PokemonInstance
	{
		#region Altaria Constructors
		/// <summary>
		/// Altaria Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Altaria(string nickname, int level)
		: base(
				AltariaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Constructor only waiting for a Level
		/// </summary>
		public Altaria(int level)
		: this( "Altaria", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Constructor waiting for no params
		/// </summary>
		/*
		public Altaria() : this( "Altaria", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}