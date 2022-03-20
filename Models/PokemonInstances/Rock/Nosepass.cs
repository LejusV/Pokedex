using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nosepass PokemonInstance Class
	#region Nosepass
	public class Nosepass : PokemonInstance
	{
		#region Nosepass Constructors
		/// <summary>
		/// Nosepass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nosepass(string nickname, int level)
		: base(
				NosepassSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Constructor only waiting for a Level
		/// </summary>
		public Nosepass(int level)
		: this( "Nosepass", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Constructor waiting for no params
		/// </summary>
		/*
		public Nosepass() : this( "Nosepass", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}