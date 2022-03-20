using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Typhlosion Species to store common natural stats of all Typhlosions
	#region TyphlosionSpecies
	public class TyphlosionSpecies : PokemonSpecies
	{
#nullable enable
		private static TyphlosionSpecies? _instance = null;
#nullable restore
        public static TyphlosionSpecies Instance => _instance ?? (_instance = new TyphlosionSpecies());

		#region TyphlosionSpecies Constructor
		public TyphlosionSpecies() : base(
			157,
			"Typhlosion",
			Fire.Instance,
			1.7,
			79.5,
			new PokemonStats(
				78, // HPs
				84, 78, // Attack & Defense
				109, 85, // Spacial Attack & Defense
				100 // Speed
			)			
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
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Nature-Power",
				"Brick-Break",
				"Eruption",
				"Secret-Power",
				"Blast-Burn",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Covet",
				"Gyro-Ball",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Lava-Plume",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Power-Up-Punch",
				"Burn-Up"
			};
		}
		#endregion
	}
	#endregion
}