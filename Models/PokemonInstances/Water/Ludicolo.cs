using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ludicolo PokemonInstance Class
	#region Ludicolo
	public class Ludicolo : PokemonInstance
	{
		#region Ludicolo Constructors
		/// <summary>
		/// Ludicolo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ludicolo(string nickname, int level)
		: base(
				LudicoloSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Constructor only waiting for a Level
		/// </summary>
		public Ludicolo(int level)
		: this( "Ludicolo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ludicolo Constructor waiting for no params
		/// </summary>
		/*
		public Ludicolo() : this( "Ludicolo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}