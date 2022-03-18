using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Silvally Species to store common natural stats of all Silvallys
	#region SpeciesSilvally
	public class SpeciesSilvally : PokemonSpecies
	{
#nullable enable
		private static SpeciesSilvally? _instance = null;
#nullable restore
        public static SpeciesSilvally Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSilvally();
                }
                return _instance;
            }
        }

		#region SpeciesSilvally Constructor
		public SpeciesSilvally() : base(
			773,
			"Silvally",
			2.3,
			100.5,
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			95		
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
				"Razor-Wind",
				"Swords-Dance",
				"Tackle",
				"Take-Down",
				"Double-Edge",
				"Bite",
				"Roar",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Toxic",
				"Rage",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Hail",
				"Facade",
				"Imprison",
				"Poison-Fang",
				"Crush-Claw",
				"Metal-Sound",
				"Aerial-Ace",
				"Dragon-Claw",
				"U-Turn",
				"Payback",
				"Heal-Block",
				"Punishment",
				"Air-Slash",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Draco-Meteor",
				"Iron-Head",
				"Double-Hit",
				"Flame-Charge",
				"Round",
				"Water-Pledge",
				"Fire-Pledge",
				"Grass-Pledge",
				"Work-Up",
				"Snarl",
				"Parting-Shot",
				"Confide",
				"Multi-Attack"
			};
		}
		#endregion
	}
	#endregion

	//Silvally PokemonInstance Class
	#region Silvally
	public class SilvallyInstance : PokemonInstance
	{
		#region Silvally Constructors
		/// <summary>
		/// Silvally Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SilvallyInstance(string nickname, int level)
		: base(
				SpeciesSilvally.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Builder only waiting for a Level
		/// </summary>
		public SilvallyInstance(int level)
		: base(
				SpeciesSilvally.Instance, // PokemonInstance Species
				"Silvally", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silvally Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SilvallyInstance() : base(
			SpeciesSilvally.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}