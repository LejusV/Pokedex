using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidoking PokemonInstance Class
	#region Nidoking
	public class Nidoking : PokemonInstance
	{
		#region Nidoking Constructors
		/// <summary>
		/// Nidoking Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nidoking(string nickname, int level)
		: base(
				NidokingSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Constructor only waiting for a Level
		/// </summary>
		public Nidoking(int level)
		: this( "Nidoking", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoking Constructor waiting for no params
		/// </summary>
		/*
		public Nidoking() : this( "Nidoking", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}