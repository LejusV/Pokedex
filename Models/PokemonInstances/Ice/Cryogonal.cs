using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cryogonal PokemonInstance Class
	#region Cryogonal
	public class Cryogonal : PokemonInstance
	{
		#region Cryogonal Constructors
		/// <summary>
		/// Cryogonal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cryogonal(string nickname, int level)
		: base(
				CryogonalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Constructor only waiting for a Level
		/// </summary>
		public Cryogonal(int level)
		: this( "Cryogonal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Constructor waiting for no params
		/// </summary>
		/*
		public Cryogonal() : this( "Cryogonal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}