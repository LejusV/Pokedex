using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Electivire PokemonInstance Class
	#region Electivire
	public class Electivire : PokemonInstance
	{
		#region Electivire Constructors
		/// <summary>
		/// Electivire Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Electivire(string nickname, int level)
		: base(
				ElectivireSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Constructor only waiting for a Level
		/// </summary>
		public Electivire(int level)
		: this( "Electivire", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Constructor waiting for no params
		/// </summary>
		/*
		public Electivire() : this( "Electivire", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}