using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ursaring Species to store common natural stats of all Ursarings
	#region UrsaringSpecies
	public class UrsaringSpecies : PokemonSpecies
	{
#nullable enable
		private static UrsaringSpecies? _instance = null;
#nullable restore
        public static UrsaringSpecies Instance => _instance ?? (_instance = new UrsaringSpecies());

		#region UrsaringSpecies Constructor
		public UrsaringSpecies() : base(
			217,
			"Ursaring",
			Normal.Instance,
			1.8,
			125.8,
			new PokemonStats(
				90, // HPs
				130, 75, // Attack & Defense
				75, 75, // Spacial Attack & Defense
				55 // Speed
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
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Lick",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Mud-Slap",
				"Zap-Cannon",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Hammer-Arm",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}