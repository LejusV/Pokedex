using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Raboot PokemonInstance Class
	#region Raboot
	public class Raboot : PokemonInstance
	{
		#region Raboot Constructors
		/// <summary>
		/// Raboot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Raboot(string nickname, int level)
		: base(
				RabootSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Constructor only waiting for a Level
		/// </summary>
		public Raboot(int level)
		: this( "Raboot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Constructor waiting for no params
		/// </summary>
		/*
		public Raboot() : this( "Raboot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}