using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Deoxys-Normal Species to store common natural stats of all Deoxys-Normals
	#region Deoxys-NormalSpecies
	public class DeoxysNormalSpecies : PokemonSpecies
	{
#nullable enable
		private static DeoxysNormalSpecies? _instance = null;
#nullable restore
        public static DeoxysNormalSpecies Instance => _instance ?? (_instance = new DeoxysNormalSpecies());

		#region Deoxys-NormalSpecies Constructor
		public DeoxysNormalSpecies() : base(
			386,
			"Deoxys-Normal",
			Psychic.Instance,
			1.7,
			60.8,
			new PokemonStats(
				50, // HPs
				150, 50, // Attack & Defense
				150, 50, // Spacial Attack & Defense
				150 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Cut",
				"Bind",
				"Headbutt",
				"Body-Slam",
				"Wrap",
				"Double-Edge",
				"Leer",
				"Ice-Beam",
				"Hyper-Beam",
				"Low-Kick",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Teleport",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Psycho-Boost",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Psycho-Shift",
				"Poison-Jab",
				"Dark-Pulse",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Low-Sweep",
				"Round",
				"Ally-Switch",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}