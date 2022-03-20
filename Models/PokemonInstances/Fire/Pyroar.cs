using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pyroar PokemonInstance Class
	#region Pyroar
	public class Pyroar : PokemonInstance
	{
		#region Pyroar Constructors
		/// <summary>
		/// Pyroar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pyroar(string nickname, int level)
		: base(
				PyroarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Constructor only waiting for a Level
		/// </summary>
		public Pyroar(int level)
		: this( "Pyroar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Constructor waiting for no params
		/// </summary>
		/*
		public Pyroar() : this( "Pyroar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}