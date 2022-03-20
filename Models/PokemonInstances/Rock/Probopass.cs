using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Probopass PokemonInstance Class
	#region Probopass
	public class Probopass : PokemonInstance
	{
		#region Probopass Constructors
		/// <summary>
		/// Probopass Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Probopass(string nickname, int level)
		: base(
				ProbopassSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Constructor only waiting for a Level
		/// </summary>
		public Probopass(int level)
		: this( "Probopass", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Probopass Constructor waiting for no params
		/// </summary>
		/*
		public Probopass() : this( "Probopass", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}