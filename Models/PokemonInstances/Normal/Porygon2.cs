using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Porygon2 PokemonInstance Class
	#region Porygon2
	public class Porygon2 : PokemonInstance
	{
		#region Porygon2 Constructors
		/// <summary>
		/// Porygon2 Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Porygon2(string nickname, int level)
		: base(
				Porygon2Species.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Constructor only waiting for a Level
		/// </summary>
		public Porygon2(int level)
		: this( "Porygon2", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon2 Constructor waiting for no params
		/// </summary>
		/*
		public Porygon2() : this( "Porygon2", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}