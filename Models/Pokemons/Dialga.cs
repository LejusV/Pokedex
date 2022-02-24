using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dialga Specie to store common natural stats of every {'abilities': ['pressure', 'telepathy'], 'base_experience': 306, 'height': 54, 'id': 483, 'moves': ['cut', 'headbutt', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'double-team', 'fire-blast', 'swift', 'flash', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'iron-tail', 'metal-claw', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'hyper-voice', 'overheat', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bulk-up', 'shock-wave', 'gravity', 'natural-gift', 'metal-burst', 'heal-block', 'magnet-rise', 'aura-sphere', 'dragon-pulse', 'power-gem', 'earth-power', 'giga-impact', 'shadow-claw', 'flash-cannon', 'trick-room', 'draco-meteor', 'iron-head', 'stone-edge', 'stealth-rock', 'roar-of-time', 'hone-claws', 'round', 'echoed-voice', 'incinerate', 'bulldoze', 'dragon-tail', 'confide'], 'name': 'dialga', 'stats': {'hp': 100, 'attack': 120, 'defense': 120, 'special-attack': 150, 'special-defense': 100, 'speed': 90}, 'types': ['steel', 'dragon'], 'weight': 6830, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ディアルガ', 'roomaji': 'Dialga', 'ko': '디아루가', 'zh-Hant': '帝牙盧卡', 'fr': 'Dialga', 'de': 'Dialga', 'es': 'Dialga', 'it': 'Dialga', 'en': 'Dialga', 'ja': 'ディアルガ', 'zh-Hans': '帝牙卢卡'}, 'genera': {'ja-Hrkt': 'じかんポケモン', 'ko': '시간포켓몬', 'zh-Hant': '時間寶可夢', 'fr': 'Pokémon Temps', 'de': 'Zeitweilig', 'es': 'Pokémon Temporal', 'it': 'Pokémon Tempo', 'en': 'Temporal Pokémon', 'ja': 'じかんポケモン', 'zh-Hans': '时间宝可梦'}}
	public class SpecieDialga : PokemonSpecie
	{
#nullable enable
		private static SpecieDialga? _instance = null;
#nullable restore
        public static SpecieDialga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDialga();
                }
                return _instance;
            }
        }

		public SpecieDialga() : base(
			"Dialga",
			100, // HPs
			120, 120, // Attack & Defense
			150, 100, // Special Attack & Defense
			90			
		) {}
	}


	//Dialga Pokemon Class
	public class Dialga : Pokemon
	{

		public Dialga(string nickname, int level)
		: base(
				483,
				SpecieDialga.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dialga() : base(
			483,
			SpecieDialga.Instance, // Pokemon Specie
			Steel.Instance, Dragon.Instance			
		) {}
	}
}