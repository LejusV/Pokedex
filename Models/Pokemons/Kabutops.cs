using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kabutops Specie to store common natural stats of every {'abilities': ['swift-swim', 'battle-armor', 'weak-armor'], 'base_experience': 173, 'height': 13, 'id': 141, 'moves': ['scratch', 'razor-wind', 'swords-dance', 'cut', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'submission', 'low-kick', 'seismic-toss', 'absorb', 'mega-drain', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'harden', 'reflect', 'bide', 'waterfall', 'skull-bash', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'sandstorm', 'giga-drain', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'nature-power', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'dive', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'mud-shot', 'water-pulse', 'brine', 'natural-gift', 'feint', 'wring-out', 'rock-polish', 'night-slash', 'aqua-tail', 'x-scissor', 'earth-power', 'giga-impact', 'rock-climb', 'stone-edge', 'captivate', 'stealth-rock', 'aqua-jet', 'hone-claws', 'smack-down', 'round', 'scald', 'confide'], 'name': 'kabutops', 'stats': {'hp': 60, 'attack': 115, 'defense': 105, 'special-attack': 65, 'special-defense': 70, 'speed': 80}, 'types': ['rock', 'water'], 'weight': 405, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'カブトプス', 'roomaji': 'Kabutops', 'ko': '투구푸스', 'zh-Hant': '鐮刀盔', 'fr': 'Kabutops', 'de': 'Kabutops', 'es': 'Kabutops', 'it': 'Kabutops', 'en': 'Kabutops', 'ja': 'カブトプス', 'zh-Hans': '镰刀盔'}, 'genera': {'ja-Hrkt': 'こうらポケモン', 'ko': '껍질포켓몬', 'zh-Hant': '甲殼寶可夢', 'fr': 'Pokémon Carapace', 'de': 'Schaltier', 'es': 'Pokémon Marisco', 'it': 'Pokémon Crostaceo', 'en': 'Shellfish Pokémon', 'ja': 'こうらポケモン', 'zh-Hans': '甲壳宝可梦'}}
	public class SpecieKabutops : PokemonSpecie
	{
#nullable enable
		private static SpecieKabutops? _instance = null;
#nullable restore
        public static SpecieKabutops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKabutops();
                }
                return _instance;
            }
        }

		public SpecieKabutops() : base(
			"Kabutops",
			60, // HPs
			115, 105, // Attack & Defense
			65, 70, // Special Attack & Defense
			80			
		) {}
	}


	//Kabutops Pokemon Class
	public class Kabutops : Pokemon
	{

		public Kabutops(string nickname, int level)
		: base(
				141,
				SpecieKabutops.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kabutops() : base(
			141,
			SpecieKabutops.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}