using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Krookodile PokemonInstance Class
	#region Krookodile
	public class Krookodile : PokemonInstance
	{
		#region Krookodile Constructors
		/// <summary>
		/// Krookodile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Krookodile(string nickname, int level)
		: base(
				KrookodileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Constructor only waiting for a Level
		/// </summary>
		public Krookodile(int level)
		: this( "Krookodile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krookodile Constructor waiting for no params
		/// </summary>
		/*
		public Krookodile() : this( "Krookodile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}