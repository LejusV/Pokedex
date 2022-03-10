using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Greninja Species to store common natural stats of all Greninjas
	#region SpeciesGreninja
	public class SpeciesGreninja : PokemonSpecies
	{
#nullable enable
		private static SpeciesGreninja? _instance = null;
#nullable restore
        public static SpeciesGreninja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGreninja();
                }
                return _instance;
            }
        }

		#region SpeciesGreninja Constructor
		public SpeciesGreninja() : base(
			"Greninja",
			1.5,
			40.0,
			72, // HPs
			95, 67, // Attack & Defense
			103, 71, // Special Attack & Defense
			122		
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
				"Pound",
				"Ice-Punch",
				"Cut",
				"Growl",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Double-Team",
				"Smokescreen",
				"Haze",
				"Lick",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Spikes",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Extrasensory",
				"Aerial-Ace",
				"Bounce",
				"Water-Pulse",
				"U-Turn",
				"Fling",
				"Dark-Pulse",
				"Night-Slash",
				"Giga-Impact",
				"Shadow-Sneak",
				"Gunk-Shot",
				"Grass-Knot",
				"Smack-Down",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Mat-Block",
				"Confide",
				"Water-Shuriken",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Greninja PokemonInstance Class
	#region Greninja
	public class GreninjaInstance : PokemonInstance
	{
		#region Greninja Constructors
		/// <summary>
		/// Greninja Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GreninjaInstance(string nickname, int level)
		: base(
				658,
				SpeciesGreninja.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Builder only waiting for a Level
		/// </summary>
		public GreninjaInstance(int level)
		: base(
				658,
				SpeciesGreninja.Instance, // PokemonInstance Species
				"Greninja", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Greninja() : base(
			658,
			SpeciesGreninja.Instance, // PokemonInstance Species
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}