using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lunala PokemonInstance Class
	#region Lunala
	public class Lunala : PokemonInstance
	{
		#region Lunala Constructors
		/// <summary>
		/// Lunala Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lunala(string nickname, int level)
		: base(
				LunalaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Constructor only waiting for a Level
		/// </summary>
		public Lunala(int level)
		: this( "Lunala", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunala Constructor waiting for no params
		/// </summary>
		/*
		public Lunala() : this( "Lunala", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}