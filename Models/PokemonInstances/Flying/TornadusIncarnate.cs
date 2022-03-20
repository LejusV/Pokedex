using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tornadus-Incarnate PokemonInstance Class
	#region Tornadus-Incarnate
	public class TornadusIncarnate : PokemonInstance
	{
		#region Tornadus-Incarnate Constructors
		/// <summary>
		/// Tornadus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TornadusIncarnate(string nickname, int level)
		: base(
				TornadusIncarnateSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Constructor only waiting for a Level
		/// </summary>
		public TornadusIncarnate(int level)
		: this( "Tornadus-Incarnate", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Constructor waiting for no params
		/// </summary>
		/*
		public TornadusIncarnate() : this( "Tornadus-Incarnate", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}