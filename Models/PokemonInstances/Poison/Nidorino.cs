using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidorino PokemonInstance Class
	#region Nidorino
	public class Nidorino : PokemonInstance
	{
		#region Nidorino Constructors
		/// <summary>
		/// Nidorino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nidorino(string nickname, int level)
		: base(
				NidorinoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Constructor only waiting for a Level
		/// </summary>
		public Nidorino(int level)
		: this( "Nidorino", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidorino Constructor waiting for no params
		/// </summary>
		/*
		public Nidorino() : this( "Nidorino", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}