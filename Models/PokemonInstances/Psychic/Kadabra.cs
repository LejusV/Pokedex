using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Kadabra PokemonInstance Class
	#region Kadabra
	public class Kadabra : PokemonInstance
	{
		#region Kadabra Constructors
		/// <summary>
		/// Kadabra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Kadabra(string nickname, int level)
		: base(
				KadabraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Constructor only waiting for a Level
		/// </summary>
		public Kadabra(int level)
		: this( "Kadabra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kadabra Constructor waiting for no params
		/// </summary>
		/*
		public Kadabra() : this( "Kadabra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}