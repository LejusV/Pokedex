using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dartrix PokemonInstance Class
	#region Dartrix
	public class Dartrix : PokemonInstance
	{
		#region Dartrix Constructors
		/// <summary>
		/// Dartrix Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dartrix(string nickname, int level)
		: base(
				DartrixSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Constructor only waiting for a Level
		/// </summary>
		public Dartrix(int level)
		: this( "Dartrix", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dartrix Constructor waiting for no params
		/// </summary>
		/*
		public Dartrix() : this( "Dartrix", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}