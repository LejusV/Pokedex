using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Klinklang PokemonInstance Class
	#region Klinklang
	public class Klinklang : PokemonInstance
	{
		#region Klinklang Constructors
		/// <summary>
		/// Klinklang Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Klinklang(string nickname, int level)
		: base(
				KlinklangSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Constructor only waiting for a Level
		/// </summary>
		public Klinklang(int level)
		: this( "Klinklang", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Klinklang Constructor waiting for no params
		/// </summary>
		/*
		public Klinklang() : this( "Klinklang", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}