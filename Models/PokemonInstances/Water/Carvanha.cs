using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Carvanha PokemonInstance Class
	#region Carvanha
	public class Carvanha : PokemonInstance
	{
		#region Carvanha Constructors
		/// <summary>
		/// Carvanha Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Carvanha(string nickname, int level)
		: base(
				CarvanhaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Constructor only waiting for a Level
		/// </summary>
		public Carvanha(int level)
		: this( "Carvanha", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Constructor waiting for no params
		/// </summary>
		/*
		public Carvanha() : this( "Carvanha", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}