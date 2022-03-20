using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sigilyph PokemonInstance Class
	#region Sigilyph
	public class Sigilyph : PokemonInstance
	{
		#region Sigilyph Constructors
		/// <summary>
		/// Sigilyph Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sigilyph(string nickname, int level)
		: base(
				SigilyphSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Constructor only waiting for a Level
		/// </summary>
		public Sigilyph(int level)
		: this( "Sigilyph", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Constructor waiting for no params
		/// </summary>
		/*
		public Sigilyph() : this( "Sigilyph", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}