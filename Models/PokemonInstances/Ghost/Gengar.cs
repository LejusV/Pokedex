using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gengar PokemonInstance Class
	#region Gengar
	public class Gengar : PokemonInstance
	{
		#region Gengar Constructors
		/// <summary>
		/// Gengar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gengar(string nickname, int level)
		: base(
				GengarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Constructor only waiting for a Level
		/// </summary>
		public Gengar(int level)
		: this( "Gengar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gengar Constructor waiting for no params
		/// </summary>
		/*
		public Gengar() : this( "Gengar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}