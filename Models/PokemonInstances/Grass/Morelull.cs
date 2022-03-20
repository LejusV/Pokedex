using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Morelull PokemonInstance Class
	#region Morelull
	public class Morelull : PokemonInstance
	{
		#region Morelull Constructors
		/// <summary>
		/// Morelull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Morelull(string nickname, int level)
		: base(
				MorelullSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Constructor only waiting for a Level
		/// </summary>
		public Morelull(int level)
		: this( "Morelull", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morelull Constructor waiting for no params
		/// </summary>
		/*
		public Morelull() : this( "Morelull", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}