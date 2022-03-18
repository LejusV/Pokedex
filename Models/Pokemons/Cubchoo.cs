using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cubchoo Species to store common natural stats of all Cubchoos
	#region SpeciesCubchoo
	public class SpeciesCubchoo : PokemonSpecies
	{
#nullable enable
		private static SpeciesCubchoo? _instance = null;
#nullable restore
        public static SpeciesCubchoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCubchoo();
                }
                return _instance;
            }
        }

		#region SpeciesCubchoo Constructor
		public SpeciesCubchoo() : base(
			613,
			"Cubchoo",
			0.5,
			8.5,
			55, // HPs
			70, 40, // Attack & Defense
			60, 40, // Special Attack & Defense
			40		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Ice-Punch",
				"Cut",
				"Thrash",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Rock-Tomb",
				"Sheer-Cold",
				"Aerial-Ace",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Assurance",
				"Fling",
				"Night-Slash",
				"Avalanche",
				"Shadow-Claw",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Cubchoo PokemonInstance Class
	#region Cubchoo
	public class CubchooInstance : PokemonInstance
	{
		#region Cubchoo Constructors
		/// <summary>
		/// Cubchoo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CubchooInstance(string nickname, int level)
		: base(
				SpeciesCubchoo.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Builder only waiting for a Level
		/// </summary>
		public CubchooInstance(int level)
		: base(
				SpeciesCubchoo.Instance, // PokemonInstance Species
				"Cubchoo", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubchoo Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CubchooInstance() : base(
			SpeciesCubchoo.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}