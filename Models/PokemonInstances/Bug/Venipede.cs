using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Venipede PokemonInstance Class
	#region Venipede
	public class Venipede : PokemonInstance
	{
		#region Venipede Constructors
		/// <summary>
		/// Venipede Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Venipede(string nickname, int level)
		: base(
				VenipedeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Constructor only waiting for a Level
		/// </summary>
		public Venipede(int level)
		: this( "Venipede", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Venipede Constructor waiting for no params
		/// </summary>
		/*
		public Venipede() : this( "Venipede", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}